import { Component, ElementRef, Input, OnInit, OnDestroy } from '@angular/core';
import { ModalService } from './../../services/modal/modal.service';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.css']
})

export class ModalComponent implements OnInit, OnDestroy {
  @Input() id: string;
  @Input() title;
  @Input() icon;

  private element: any;

  constructor(private modalService: ModalService, private el: ElementRef) {
      this.element = el.nativeElement;
  }

  ngOnInit(): void {
      const modal = this;

      if (!this.id) {
          console.error('modal must have an id');
          return;
      }

      document.body.appendChild(this.element);

      this.element.addEventListener('click', function(e: any) {
          if (e.target.className === 'modal') {
              modal.close();
          }
      });

      this.modalService.add(this);
  }

  ngOnDestroy(): void {
      this.modalService.remove(this.id);
      this.element.remove();
  }

  open(): void {
      this.element.style.display = 'block';
      document.body.classList.add('modal-open');
  }

  close(): void {
      this.element.style.display = 'none';
      document.body.classList.remove('modal-open');
  }
}

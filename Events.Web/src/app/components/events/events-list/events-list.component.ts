import { Component, OnInit, ViewChild } from '@angular/core';
import { ModalService } from 'src/app/services/modal/modal.service';

import { Event } from '../../../models/event';
import { EventService } from '../../../services/event/event.service';
import { EventEditComponent } from '../event-edit/event-edit.component';

@Component({
  selector: 'app-events-list',
  templateUrl: './events-list.component.html',
  styleUrls: ['./events-list.component.css'],
  providers: [ModalService]
})

export class EventsListComponent implements OnInit {

  events: Event[];

  loading = true;
  open = false;

  @ViewChild('eventForm') eventEditComponent: EventEditComponent;

  constructor(private service: EventService, public modalService: ModalService) { }

  ngOnInit() {
    this.service.getAllEvents().subscribe((response: Event[]) => {
      this.events = response;
      this.showloading();
    });
  }

  showloading() {
    window.setTimeout(() => {
      this.loading = false;
    }, 1000);
  }

  onEdit(id: string) {
    if (id) {
      this.open = true;
      this.eventEditComponent.getEventById(id);
      this.modalService.open('event-edit');
    }
  }

}

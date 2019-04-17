import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

import { Event } from '../../../models/event';
import { ModalService } from 'src/app/services/modal/modal.service';
import { EventService } from 'src/app/services/event/event.service';

@Component({
  selector: 'app-event-edit',
  templateUrl: './event-edit.component.html',
  styleUrls: ['./event-edit.component.css']
})

export class EventEditComponent implements OnInit {

  event = new Event();
  eventFormGroup: FormGroup;
  loading = true;

  constructor(public modalService: ModalService, private service: EventService) {
  }

  getEventById(id: string) {
    this.service.getById(id).subscribe((response: Event) => {
      this.event = response;
      this.eventToFormControl();
      this.loading = false;
    });
  }

  ngOnInit() {
    this.initFormGroup();
  }

  initFormGroup() {
    this.eventFormGroup = new FormGroup({
      name: new FormControl('', Validators.required),
      shortDescription: new FormControl('', Validators.required),
      companyName: new FormControl('', Validators.required)
    });
  }

  eventToFormControl() {
    if (this.event) {
      this.eventFormGroup.setValue({
        name: this.event.name,
        companyName: this.event.companyName,
        shortDescription: this.event.shortDescription
      });
    }
  }

  onSubmit(value) {

  }
}

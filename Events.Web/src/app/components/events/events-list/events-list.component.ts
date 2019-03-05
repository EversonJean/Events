import { Component, OnInit } from '@angular/core';
import { EventService } from '../../../services/event/event.service';

import { Event } from '../../../models/event';

@Component({
  selector: 'app-events-list',
  templateUrl: './events-list.component.html',
  styleUrls: ['./events-list.component.css']
})
export class EventsListComponent implements OnInit {

  Events: Event[];

  constructor(private service: EventService) { }

  ngOnInit() {
    this.service.getAllEvents().subscribe((response: Event[]) => {
      this.Events = response;
    });
  }

}

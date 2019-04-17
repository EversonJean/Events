import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { EventsListComponent } from './components/events/events-list/events-list.component';

const routes: Routes = [
  {
    path: 'events', component: EventsListComponent
  },
  {
    path: '**', redirectTo: ''
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventsComponent } from './components/events/events.component';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { MenuComponent } from './components/menu/menu.component';
import { EventsListComponent } from './components/events/events-list/events-list.component';

import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    EventsComponent,
    MenuComponent,
    EventsListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule.forRoot(),
    NgxDatatableModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }

export class Event {
  Id: number;
  Name: string;
  ShortDescrition: string;
  FullDescription: string;
  StartDate: Date;
  EndDate: Date;
  Free: boolean;
  Value: number;
  Online: boolean;
  CompanyName: string;
  Address: any;
  Category: any;
  Organizer: any;

  constructor(id: number, name: string) {
    this.Id = id;
    this.Name = name;
  }
}

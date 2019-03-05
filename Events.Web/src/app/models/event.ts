export interface  Event {
  id: number;
  name: string;
  shortDescrition: string;
  fullDescription: string;
  startDate: Date;
  endDate: Date;
  free: boolean;
  value: number;
  online: boolean;
  companyName: string;

  // Address: any;
  // Category: any;
  // Organizer: any;

  // constructor(id: number, name: string) {
  //   this.Id = id;
  //   this.Name = name;
  // }
}

import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public doctors: Doctor[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Doctor[]>(baseUrl + 'api/Doctor/Buscar').subscribe(result => {
      this.doctors = result;
    }, error => console.error(error));
  }
}

interface Doctor {
  Id: number;
  NameComplete: string;
  Specialty: string;
  AccountNumber: number;
  Hospital: string;
}




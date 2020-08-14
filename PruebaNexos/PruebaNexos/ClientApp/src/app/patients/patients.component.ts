import { Component, OnInit } from '@angular/core';
import { IPatient } from './patient';
import { PatientsService } from './patients.service';

@Component({
  selector: 'app-patients',
  templateUrl: './patients.component.html',
  styleUrls: ['./patients.component.css']
})
export class PatientsComponent implements OnInit {

  patients: IPatient[];

  constructor(private patientsService: PatientsService) { }

  ngOnInit(): void {
    this.LoadPatients();
  }

  delete(patient: IPatient) {
    console.table(patient);
    this.patientsService.deletePatient(patient.id.toString()).subscribe(patient => this.LoadPatients(),
      error => console.error(error));
  }

  LoadPatients() {
    this.patientsService.getPatients().subscribe(patients => this.patients = patients,
      error => console.error(error));
  }

}

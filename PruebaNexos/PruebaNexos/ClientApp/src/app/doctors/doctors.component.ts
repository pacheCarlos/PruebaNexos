import { Component, OnInit } from '@angular/core';
import { IDoctor } from './doctor';
import { DoctorsService } from './doctors.service';

@Component({
  selector: 'app-doctors',
  templateUrl: './doctors.component.html',
  styleUrls: ['./doctors.component.css']
})
export class DoctorsComponent implements OnInit {

  doctors: IDoctor[];

  constructor(private doctorsService: DoctorsService) { }

  ngOnInit(): void {
    this.LoadDoctors();
  }

  delete(doctor: IDoctor) {
    console.table(doctor);
    this.doctorsService.deleteDoctor(doctor.id.toString()).subscribe(doctor => this.LoadDoctors(),
      error => console.error(error));
  }

  LoadDoctors() {
    this.doctorsService.getDoctors().subscribe(doctors => this.doctors = doctors,
      error => console.error(error));
  }

}

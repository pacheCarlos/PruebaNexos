import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IDoctor } from '../doctor';
import { DoctorsService } from '../doctors.service';
import { Router, ActivatedRoute } from '@angular/router';
import { error } from 'protractor';

@Component({
  selector: 'app-doctors-form',
  templateUrl: './doctors-form.component.html',
  styleUrls: ['./doctors-form.component.css']
})
export class DoctorsFormComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private doctorService: DoctorsService,
    private router: Router,
    private activedRoute: ActivatedRoute) { }

  modEdit: boolean = false;
  doctorId: number;

  formGroup: FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      nameComplete: '',
      specialty: '',
      accountNumber: 0,
      hospital: ''
    });

    this.activedRoute.params.subscribe(params => {
      if (params["id"] == undefined) {
        return;
      }

      this.modEdit = true;
      this.doctorId = params["id"];

      this.doctorService.getDoctor(this.doctorId.toString()).subscribe(doctor => this.LoadDoctor(doctor),
        error => console.error(error));
    });
  }

  save() {
    let doctor: IDoctor = Object.assign({}, this.formGroup.value);

    if (this.modEdit) {
      doctor.id = Number(this.doctorId);
      console.table(doctor);
      this.doctorService.updateDoctor(doctor).subscribe(doctor => this.CreateDoctor(),
        error => console.error(error));
    }
    else {
      this.doctorService.createDoctor(doctor).subscribe(doctor => this.CreateDoctor(),
        error => console.error(error));
    }
  }

  CreateDoctor() {
    this.router.navigate(["/doctors"]);
  }

  LoadDoctor(doctor: IDoctor) {
    this.formGroup.patchValue({
      nameComplete: doctor.nameComplete,
      specialty: doctor.specialty,
      accountNumber: doctor.accountNumber,
      hospital: doctor.hospital
    });
  }
}

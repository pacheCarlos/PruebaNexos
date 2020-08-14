import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IPatient } from '../patient';
import { PatientsService } from '../patients.service';
import { Router, ActivatedRoute } from '@angular/router';
import { error } from 'protractor';

@Component({
  selector: 'app-patients-form',
  templateUrl: './patients-form.component.html',
  styleUrls: ['./patients-form.component.css']
})
export class PatientsFormComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private patientService: PatientsService,
    private router: Router,
    private activedRoute: ActivatedRoute) { }

  modEdit: boolean = false;
  patientId: number;

  formGroup: FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      nameComplete: '',
      socialSecurityNumber: 0,
      zipCode: 0,
      phone: 0
    });

    this.activedRoute.params.subscribe(params => {
      if (params["id"] == undefined) {
        return;
      }

      this.modEdit = true;
      this.patientId = params["id"];

      this.patientService.getPatient(this.patientId.toString()).subscribe(patient => this.LoadPatient(patient),
        error => console.error(error));
    });
  }

  save() {
    let patient: IPatient = Object.assign({}, this.formGroup.value);

    if (this.modEdit) {
      patient.id = Number(this.patientId);
      console.table(patient);
      this.patientService.updatePatient(patient).subscribe(patient => this.CreatePatient(),
        error => console.error(error));
    }
    else {
      console.table(patient);
      this.patientService.createPatient(patient).subscribe(patient => this.CreatePatient(),
        error => console.error(error));
    }
  }

  CreatePatient() {
    this.router.navigate(["/patients"]);
  }

  LoadPatient(patient: IPatient) {
    this.formGroup.patchValue({
      nameComplete: patient.nameComplete,
      socialSecurityNumber: patient.socialSecurityNumber,
      zipCode: patient.zipCode,
      phone: patient.phone
    });
  }

}

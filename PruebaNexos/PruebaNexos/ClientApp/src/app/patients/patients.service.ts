import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IPatient } from './patient';

@Injectable({
  providedIn: 'root'
})
export class PatientsService {

  private apiURL = this.baseUrl + "api/Patient"

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getPatients(): Observable<IPatient[]> {
    return this.http.get<IPatient[]>(this.apiURL + "/Buscar");
  }

  getPatient(patientId: string): Observable<IPatient> {
    return this.http.get<IPatient>(this.apiURL + "/Buscar/" + patientId);
  }

  createPatient(patient: IPatient): Observable<IPatient> {
    return this.http.post<IPatient>(this.apiURL + "/CrearPaciente", patient);
  }

  updatePatient(patient: IPatient): Observable<IPatient> {
    return this.http.put<IPatient>(this.apiURL + "/ActualizarPaciente", patient);
  }

  deletePatient(patientId: string): Observable<IPatient> {
    return this.http.delete<IPatient>(this.apiURL + "/Eliminar/" + patientId);
  }
}

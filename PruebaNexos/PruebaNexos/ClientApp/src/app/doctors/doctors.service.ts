import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IDoctor } from './doctor';

@Injectable({
  providedIn: 'root'
})
export class DoctorsService {

  private apiURL = this.baseUrl + "api/Doctor"

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getDoctors(): Observable<IDoctor[]> {
    return this.http.get<IDoctor[]>(this.apiURL + "/Buscar");
  }

  getDoctor(doctorId: string): Observable<IDoctor> {
    return this.http.get<IDoctor>(this.apiURL + "/Buscar/" + doctorId);
  }

  createDoctor(doctor: IDoctor): Observable<IDoctor> {
    return this.http.post<IDoctor>(this.apiURL + "/CrearDoctor", doctor);
  }

  updateDoctor(doctor: IDoctor): Observable<IDoctor> {
    return this.http.put<IDoctor>(this.apiURL + "/ActualizarDoctor", doctor);
  }

  deleteDoctor(doctorId: string): Observable<IDoctor> {
    return this.http.delete<IDoctor>(this.apiURL + "/Eliminar/" + doctorId);
  }
}

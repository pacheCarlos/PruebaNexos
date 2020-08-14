import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { DoctorsComponent } from './doctors/doctors.component';
import { DoctorsService } from './doctors/doctors.service';
import { DoctorsFormComponent } from './doctors/doctors-form/doctors-form.component';
import { PatientsComponent } from './patients/patients.component';
import { PatientsService } from './patients/patients.service';
import { PatientsFormComponent } from './patients/patients-form/patients-form.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    DoctorsComponent,
    DoctorsFormComponent,
    PatientsComponent,
    PatientsFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'doctors', component: DoctorsComponent },
      { path: 'doctors-add', component: DoctorsFormComponent },
      { path: 'doctors-add/:id', component: DoctorsFormComponent },
      { path: 'patients', component: PatientsComponent },
      { path: 'patients-add', component: PatientsFormComponent },
      { path: 'patients-add/:id', component: PatientsFormComponent },
    ])
  ],
  providers: [DoctorsService],//, PatientsService],
  bootstrap: [AppComponent]
})
export class AppModule { }

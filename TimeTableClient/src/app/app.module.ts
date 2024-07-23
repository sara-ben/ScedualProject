import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './Componets/login/login.component';
import { RegisterComponent } from './Componets/register/register.component';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatCardModule} from '@angular/material/card';
import { ReactiveFormsModule } from '@angular/forms';
import { ScheduleComponent } from './Componets/schedule/schedule.component';
import {MatSelectModule} from '@angular/material/select';
import { HttpClientModule, HttpClient  } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AllConstrainsComponent } from './Componets/all-constrains/all-constrains.component';
import { NavComponent } from './Componets/nav/nav.component';
import {MatTabsModule} from '@angular/material/tabs';
import { EditSchedualComponent } from './Componets/edit-schedual/edit-schedual.component';
import { MatIconModule } from "@angular/material/icon";
import { ScedualPerTeacherComponent } from './Componets/scedual-per-teacher/scedual-per-teacher.component';
import { CustomJsonPipe } from './Services/subject-for-cycle.service';





@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    ScheduleComponent,
    AllConstrainsComponent,
    NavComponent,
    EditSchedualComponent,
    ScedualPerTeacherComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatButtonModule,
    MatInputModule,
    MatButtonModule,
    MatCardModule,
    ReactiveFormsModule,
    MatSelectModule,
    HttpClientModule,
    FormsModule,
    MatTabsModule,
    MatIconModule,
    
  ],
  providers: [HttpClientModule,CustomJsonPipe],
  bootstrap: [AppComponent]
})
export class AppModule { }

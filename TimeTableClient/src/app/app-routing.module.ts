import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllConstrainsComponent } from './Componets/all-constrains/all-constrains.component';
import { LoginComponent } from './Componets/login/login.component';
import { NavComponent } from './Componets/nav/nav.component';
import { ScheduleComponent } from './Componets/schedule/schedule.component';

const routes: Routes = [

 
  //  path: 'Constrains', component: AllConstrainsComponent,
  { path: '', component: NavComponent,}

// {path: '', component: LoginComponent},
// {path: 'home', component: NavComponent, children:[
  // {path: 'Login', component: LoginComponent,}
//   { path: 'LogIn', component: LoginComponent},
//   { path: 'Schedule', component: ScheduleComponent},
//   { path: 'Constrains', component: AllConstrainsComponent},
]
// path: 'Schedule', component: ScheduleComponent

// }
// ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

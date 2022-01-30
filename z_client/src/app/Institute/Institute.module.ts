import { NgModule } from '@angular/core';
import { AppRoutingModule } from '../app-routing.module';
import { InstituteComponent } from './Institute.component';
import { InstituteProfileComponent } from './InstituteProfile/InstituteProfile.component';
import { InstituteSetUpComponent } from './InstituteSetUp/InstituteSetUp.component';


@NgModule({
  imports: [
    AppRoutingModule
  ],
  declarations: [
    InstituteComponent,
    InstituteProfileComponent,
    InstituteSetUpComponent

  ]
})
export class InstituteModule { }

import { NgModule } from '@angular/core';
import { AppRoutingModule } from '../app-routing.module';
import { EditContactInstituteComponent } from './InstituteProfile/editContactInstitute/editContactInstitute.component';
import { InstituteComponent } from './Institute.component';
import { EditDescribtionComponent } from './InstituteProfile/editDescribtion/editDescribtion.component';
import { InstituteProfileComponent } from './InstituteProfile/InstituteProfile.component';
import { InstituteSetUpComponent } from './InstituteSetUp/InstituteSetUp.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  imports: [
    AppRoutingModule,
    ReactiveFormsModule
  ],
  declarations: [
    InstituteComponent,
    InstituteProfileComponent,
    InstituteSetUpComponent,
    EditDescribtionComponent,
    EditContactInstituteComponent

  ]
})
export class InstituteModule { }

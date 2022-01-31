import { NgModule } from '@angular/core';
import { courselistcomponent } from './Courses/Course-list/course-list.component';
import { RouterModule, Routes } from '@angular/router';
import { Usercomponent } from './User/user.component';
import { fetchDataComponent } from './fetch-data/fetch-data.component';
import { countercomponent } from './countery/countery.component';
import { homecomponent } from './Home/home.component';
import { CityComponent } from './City/City.Component';
import{AuthGuard}from'./gruid/auth.guard'
import { UserDetailsComponent } from './User/UserDetails/user-details.component';
import { userEditComponent } from './User/UserEdit/user-edit.component';
import { InstituteComponent } from './Institute/Institute.component';
import { InstituteProfileComponent } from './Institute/InstituteProfile/InstituteProfile.component';
import { InstituteSetUpComponent } from './Institute/InstituteSetUp/InstituteSetUp.component';
import { EditDescribtionComponent } from './Institute/InstituteProfile/editDescribtion/editDescribtion.component';
import { EditContactInstituteComponent } from './Institute/InstituteProfile/editContactInstitute/editContactInstitute.component';
import { EditInfoInstituteComponent } from './Institute/InstituteProfile/editInfoInstitute/editInfoInstitute.component';

const routes: Routes = [
  {path:'Institute',component:InstituteComponent,
  children:[
    {path:'',component:InstituteSetUpComponent},
    {path:':id/EditInstituteProfile',component:InstituteProfileComponent,
                                    children:[
                                      {path:'editDescribtion',component:EditDescribtionComponent},
                                      {path:'editContact',component:EditContactInstituteComponent},
                                      {path:'editIndo',component:EditInfoInstituteComponent},
                                   ]},
  ]},
  {path:'courses',component:courselistcomponent},
          {path:'editUser',component:userEditComponent},
          {path:'user',component:Usercomponent,
        children:[
          {path:'user/:userName',component:UserDetailsComponent},
          {path:'editUser',component:userEditComponent}
        ]},
  {path:'user/:userName',component:UserDetailsComponent},
  {path:'fetch-data',component:fetchDataComponent},
  {path:'countery',component:countercomponent},
  {path:'home',component:homecomponent},
  {path:'city',component:CityComponent},

  {path:'',component:homecomponent,pathMatch:'full'},
  {path:'**',component:homecomponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }


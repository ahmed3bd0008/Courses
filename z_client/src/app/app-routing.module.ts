import { NgModule } from '@angular/core';
import { courselistcomponent } from './Courses/Course-list/course-list.component';
import { RouterModule, Routes } from '@angular/router';
import { Usercomponent } from './User/user.component';
import { fetchDataComponent } from './fetch-data/fetch-data.component';
import { countercomponent } from './countery/countery.component';
import { homecomponent } from './Home/home.component';
import { CityComponent } from './City/City.Component';

const routes: Routes = [
  {path:'courses',component:courselistcomponent},
  {path:'user',component:Usercomponent},
  {path:'',component:homecomponent,pathMatch:'full'},
  {path:'fetch-data',component:fetchDataComponent},
  {path:'countery',component:countercomponent},
  {path:'home',component:homecomponent},
  {path:'city',component:CityComponent},
  {path:'**',component:homecomponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

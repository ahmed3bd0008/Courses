import { NgModule } from '@angular/core';
import { courselistcomponent } from './Courses/Course-list/course-list.component';
import { RouterModule, Routes } from '@angular/router';
import { Usercomponent } from './User/user.component';

const routes: Routes = [
  {path:'courses',component:courselistcomponent},
  {path:'user',component:Usercomponent},
  {path:'',component:courselistcomponent,pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

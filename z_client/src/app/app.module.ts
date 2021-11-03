import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { countercomponent } from './countery/countery.component';
import { courselistcomponent } from './Courses/Course-list/course-list.component';
import { coursecomponent } from './Courses/course/course.component';
import { coursecatagorycomponent } from './Courses/coursecatagory/course-catagory.component';
import { courselevelcomponent } from './Courses/courseLevel/course-level.component';
import { courseratecomponent } from './Courses/courseRating/course-rate.component';
import { coursestatuscomponent } from './Courses/courseStatus/course-status.component';
import { coursetrackcomponent } from './Courses/courseTrack/course-track.component';
import { coursetypecomponent } from './Courses/courseType/course-type.component';
import { fetchDataComponent } from './fetch-data/fetch-data.component';
import { homecomponent } from './Home/home.component';
import { navcomponent } from './Nav/nav.component';
import { Usercomponent } from './User/user.component';
<<<<<<< HEAD
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
//mateDialog 
import {MatDialogModule} from '@angular/material/dialog';
=======
import { HttpClientModule}from'@angular/common/http'
>>>>>>> 4e1a58bbcb97b21a4b5d72ddae2088613d84dc9b
@NgModule({
  declarations: [
    AppComponent,
    navcomponent,
    courselistcomponent,
    courselevelcomponent,
    coursecatagorycomponent,
    courseratecomponent,
    coursestatuscomponent,
    coursetrackcomponent,
    coursetypecomponent,
    coursecomponent,
    Usercomponent,
    homecomponent,
    countercomponent,
    fetchDataComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
<<<<<<< HEAD
    BrowserAnimationsModule,
    MatDialogModule
=======
    HttpClientModule
>>>>>>> 4e1a58bbcb97b21a4b5d72ddae2088613d84dc9b
  ],
  providers: [ ],
  exports:   [ AppComponent ],
  bootstrap: [AppComponent]
})
export class AppModule { }

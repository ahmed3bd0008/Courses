import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { CourseLevel } from "../../../courseLevel/Course-level";
import { ResponseClient } from "../../../../ResponseClient";
import{courselevelservice}from "../../courselevel.service";
@Component({
  selector: 'app-select-course',
  templateUrl: './select-course.component.html',
  styleUrls: ['./select-course.component.css']
})
export class SelectCourseComponent implements OnInit {
  constructor(private client:HttpClient,private courselevelserv:courselevelservice  ) { }
  courselevels:CourseLevel[]=[];
  getcourseLevel(){
    console.log("asd")
    this.client.get<ResponseClient>('https://localhost:5001/CourseSystem/GetAllCourseLevel').subscribe((courseLevels:ResponseClient)=>{
      console.log(courseLevels.data as CourseLevel)
      this.courselevels=courseLevels.data as CourseLevel[]
     },error=>{
       console.log(error);
     }
     )
  }
  GetLevelCourseLevel(){
   this.courselevelserv.getCourseLevel().subscribe(arg =>{
    const courselev:CourseLevel[]=arg.data as CourseLevel[];
    this.courselevels=courselev;
    console.log(courselev)
       })
  }
    ngOnInit(): void {
    //this.getcourseLevel();
    this.GetLevelCourseLevel();
  }
}

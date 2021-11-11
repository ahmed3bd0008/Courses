import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { CourseLevel } from "../../../courseLevel/Course-level";
import { ResponseClient } from "../../../../ResponseClient";
@Component({
  selector: 'app-select-course',
  templateUrl: './select-course.component.html',
  styleUrls: ['./select-course.component.css']
})
export class SelectCourseComponent implements OnInit {

  constructor(private client:HttpClient) { }
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
  ngOnInit(): void {
    this.getcourseLevel();
  }

}

import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { CourseLevel } from "./Course-level";
import{map}from"rxjs/operators"
@Injectable({
  providedIn:'root'
})
export class courselevelservice
{
  baseUrl:string='https://localhost:5001/CourseSystem/'
  constructor(private client:HttpClient){}
  getCourseLevel(){
    this.client.get<CourseLevel>(this.baseUrl+'GetAllCourseLevel')
  }
}



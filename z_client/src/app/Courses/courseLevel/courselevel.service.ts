import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import{ResponseClient}from "../../ResponseClient"
import{map}from"rxjs/operators"
@Injectable({
  providedIn:'root'
})
export class courselevelservice
{
  baseUrl:string='https://localhost:5001/CourseSystem/'
  constructor(private client:HttpClient){}
  getCourseLevel(){
   return  this.client.get<ResponseClient>(this.baseUrl+'GetAllCourseLevel'). pipe
    (map((Response)=>
    {
      const Responsecl=Response
      return Responsecl;
      },))
  }
}



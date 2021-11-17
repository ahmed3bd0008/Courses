import{map}from"rxjs/operators";
import{ResponseClient}from"../../ResponseClient";
import { Injectable } from '@angular/core'
import { HttpClient } from "@angular/common/http";
@Injectable({
  providedIn:"root"
})
export  class coursecatagoryservice
{
  private basicUrl:string='https://localhost:5001/CourseSystem/';
  constructor(private client:HttpClient){}
  getCategory(){
    return this.client.get<ResponseClient>(this.basicUrl+'GetAllCourseCategory').pipe(
      map(response=>{
        const courseCategoryResponse:ResponseClient=response
        return courseCategoryResponse;
      }))
  }
}

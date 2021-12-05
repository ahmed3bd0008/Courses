import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { ResponseClient } from "src/app/ResponseClient";
import { environment } from "src/environments/environment";

@Injectable({
  providedIn:'root'
})
export class courseTrackService
{
  baseUrl:string="https://localhost:5001"
  constructor(private client:HttpClient) {
  }
  getAllCourseTrack(){
      return this.client.get<ResponseClient>(this.baseUrl+'/CourseSystem/GetAllCourseTrack')
      .pipe(map(Response=>{
        return Response;
      }))
  }
}

import { Injectable, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import{map}from "rxjs/operators"
import { RegistUser } from "./RegistUse";
import { environment } from "src/environments/environment";
import{ResponseClient}from'../../app/ResponseClient';
import { UserDispalay } from "../Nav/User";


// const option={
//   headers:new HttpHeaders({
//     authorization:'Bearer ' + JSON.parse( localStorage.getItem('user')||'{}') .token
//   })
// }


@Injectable({
  providedIn:"root"
})

export class RegisterService {


BaseUrl:string=environment.baseUrl+'/Authencations';
constructor(private clint: HttpClient){

}

register(Model:RegistUser)
{
  return this.clint.post<number>(this.BaseUrl+'/CreateUser',Model).
  pipe(map((Response)=>
  {const user=Response
    return user;
    },
    )
  )
}

getAllUser(){
  //return this.clint.get<UserDispalay[]>(this.BaseUrl+'/GetAllUser',option)
  return this.clint.get<UserDispalay[]>(this.BaseUrl+'/GetAllUser')
}
getUserByUserName(userName:string){
  //return this.clint.get<ResponseClient>(this.BaseUrl+'/GetUserByName/userName/'+userName,option)
  return this.clint.get<ResponseClient>(this.BaseUrl+'/GetUserByName/userName/'+userName)
}
}

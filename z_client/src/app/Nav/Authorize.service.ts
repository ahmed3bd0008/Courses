import { Injectable } from "@angular/core";
import{HttpClient}from"@angular/common/http"
import { User, Usertoken } from "./User";
import{map}from"rxjs/operators";
import{ReplaySubject}from"rxjs"
import { environment } from "src/environments/environment";
@Injectable(
  {
    providedIn:"root"
  }
)
export class Authorizeservice
{
  BaseUrl:string=environment.baseUrl+"/Authencations"
  //buufer Not UnderStand Why Use it
   private currentUsersourc=new ReplaySubject<Usertoken>(1);
   currentuser$=this.currentUsersourc.asObservable();
  constructor(private client:HttpClient)
  {

  }
getCurrentuser(user:Usertoken)
{
  this.currentUsersourc.next(user);
}
log(Model:User)
{
  return this.client.post<Usertoken>(this.BaseUrl+'/logInUse',Model).
      pipe(map((Response:Usertoken)=>
      {const user=Response
        if (user.token!=null) {
            console.log(user);
            localStorage.setItem("user",JSON.stringify(user));
            this.getCurrentuser(user);
        }
      }
        )
      )
}
logout()
{
  localStorage.removeItem("user")
  this.currentUsersourc.next();
}
}

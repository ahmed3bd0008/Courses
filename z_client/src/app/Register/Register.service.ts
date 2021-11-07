import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import{map}from "rxjs/operators"
import { RegistUser } from "./RegistUse";
@Injectable({
  providedIn:"root"
})
export class RegisterService{
BaseUrl:string='https://localhost:5001/Authencations';
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
}

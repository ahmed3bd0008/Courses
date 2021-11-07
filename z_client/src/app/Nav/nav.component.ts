import { Component, OnInit } from "@angular/core";
import { User,Usertoken } from "./User";
import{Authorizeservice}from'./Authorize.service'
import { NgForm } from "@angular/forms";
import { Observable } from "rxjs";
import { Router } from "@angular/router";
@Component(
  {
    selector:'nav-app',
    templateUrl:'./nav.component.html'
  }
)
export class navcomponent implements OnInit
{
 userName:string="";
 password:string="";
 loggin:boolean=false;
  constructor(public authservice: Authorizeservice,private rout:Router)
  {

  }
  ngOnInit(): void {
    this.getUser();
    //this.userServices$= this.authservice.currentuser$
  }
getLoginUser(module:User)
{
  console.log("gfdsgdf")
  console.log(module);
    // this.authservice.log(module).subscribe(Response=>{
    //   console.log(Response)
    // },
    // error=>{
    //   console.log(error)
    // })
}
onSubmit(logForm:NgForm)
{
  this.authservice.log(logForm.value).subscribe(Response=>{
       this.loggin=true;
       this.rout.navigateByUrl('/courses')
  },
  error=>{
    console.log(error)
    this.loggin=false;
   });
}
logout()
{
  this.authservice.logout();
  this.rout.navigateByUrl('/')
  this.loggin=false;
}
getUser()
{
  this.authservice.currentuser$.subscribe(user=>{
    this.loggin=!!user;
  },
  error=>{
    console.log(error);
  }
  )
}
}

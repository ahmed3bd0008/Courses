import { Component, OnInit } from '@angular/core';
import{Authorizeservice}from'./Nav/Authorize.service';
import{Usertoken}from'./Nav/User';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'client';
  constructor(private authservice:Authorizeservice)
{

}
  ngOnInit(): void {
   this.
   getUser();
  }
  getUser()
{
  if (localStorage.getItem('user')) {

    const user:Usertoken=JSON.parse(localStorage.getItem('user')||"no user")
    this.authservice.getCurrentuser(user);
  }
}
}

import { Component,OnInit } from "@angular/core";
import { RegisterService } from "../Register/Register.service";

@Component({
  selector:'user-app',
  templateUrl:'./user.component.html'
})
export class Usercomponent implements OnInit
{
  /**
   *RegisterService
   */
  constructor(private registService:RegisterService) {

  }
  ngOnInit(): void {
    this.getAllUser();
  }
  getAllUser(){
    this.registService.getAllUser().subscribe(
      Response=>{
        console.log(Response);
      },error=>{
        console.log(error)
      }
    )
  }
}

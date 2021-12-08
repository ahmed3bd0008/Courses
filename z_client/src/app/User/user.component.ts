import { Component,OnInit } from "@angular/core";
import { UserDispalay } from "../Nav/User";
import { RegisterService } from "../Register/Register.service";

@Component({
  selector:'user-app',
  templateUrl:'./user.component.html',
  styleUrls:['./user.component.css']
})
export class Usercomponent implements OnInit
{
  /**
   *RegisterService
   */
  defaultrImage:string='https://th.bing.com/th/id/OIP.F5jwVbaqtqnav-gsxBDLOQAAAA?pid=ImgDet&w=200&h=200&rs=1'
  Users:UserDispalay[]=[];
  constructor(private registService:RegisterService) {

  }
  ngOnInit(): void {
    this.getAllUser();
  }
  getAllUser(){
    this.registService.getAllUser().subscribe(
      Response=>{
          this.Users=Response as UserDispalay[]
          console.log(this.Users)
      },error=>{
        console.log(error)
      }
    )
  }
}

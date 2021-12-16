import { Component, OnInit } from "@angular/core";
import { take } from "rxjs/operators";
import { Authorizeservice } from "src/app/Nav/Authorize.service";
import { UserDispalay, Usertoken } from "src/app/Nav/User";
import { RegisterService } from "src/app/Register/Register.service";

@Component({
  selector:'./user-edit-app',
  templateUrl:'./user-edit.component.html',
  styleUrls:['./user-edit.component.css']
})
export  class userEditComponent implements OnInit {
/**
 *
 */
user !:Usertoken;
userdispaly !:UserDispalay
defaultPhoto:string='https://th.bing.com/th/id/OIP.F5jwVbaqtqnav-gsxBDLOQAAAA?pid=ImgDet&w=200&h=200&rs=1';
constructor(private rgistser:RegisterService ,private authservice:Authorizeservice) {
authservice.currentuser$.pipe(take(1)).subscribe(member=>this.user=member);
}
  ngOnInit(): void {
      this.onload();
  }
  onload()
  {
    this.rgistser.getUserByUserName(this.user.userName).subscribe(Response=>{
      this.userdispaly=Response;
      console.log(Response);
    },error=>{
      console.log(error);
    }
    )
  }

}

import { Component, Input, OnInit } from "@angular/core";
import { take } from "rxjs/operators";
import { Countery } from "src/app/countery/countery";
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

 countery:Countery={id:'',name:''};
 selectcounteryp:string='';
 selectCity:string=''
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
      this.selectCity=Response.cityId;
      this.selectcounteryp=Response.counteryId;

    },error=>{
      console.log(error);
    }
    )
  }
  addItem(newItem: Countery) {
    this.countery =newItem;
    console.log(newItem)
  }

}

import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { RegisterService } from "src/app/Register/Register.service";
@Component({
  selector:'user-details-app',
  templateUrl:'./user-details.component.html',
  styleUrls:['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit{
  /**
   *
   */
  constructor(private userServic:RegisterService,private router:ActivatedRoute) {

  }
  ngOnInit(): void {
    console.log("new")
    this.getUser();
  }
  getUser(){
    console.log("fdsfsdfsdf")
    this.userServic.getUserByUserName(this.router.snapshot.paramMap.
      get('userName')!)
      .subscribe(memmber=>
        {
          console.log(memmber)
          console.log("fdgds")
        },error=>{
          console.log(error)
        })
  }
}

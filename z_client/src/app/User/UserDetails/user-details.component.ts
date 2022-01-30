import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { NgxGalleryAnimation, NgxGalleryImage, NgxGalleryOptions } from "@kolkov/ngx-gallery";
import { User, UserDispalay } from "src/app/Nav/User";
import { RegisterService } from "src/app/Register/Register.service";
import { ResponseClient } from "src/app/ResponseClient";
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
  gallaryoption :NgxGalleryOptions[]=[];
  gallayImage :NgxGalleryImage[]=[];
  userdispaly!: UserDispalay ;
  active:number = 1;
  defaultPhoto:string='https://th.bing.com/th/id/OIP.F5jwVbaqtqnav-gsxBDLOQAAAA?pid=ImgDet&w=200&h=200&rs=1';
  ngOnInit(): void {
    this.getUser();
    this.gallaryoption = [
      {
        width: '600px',
        height: '400px',
        imagePercent:100,
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide
      },
    ];
    this.gallayImage=this.getImag();
  }
  getImag():any{
    let imgeUrl:NgxGalleryAnimation[]=[];
    for(const photo of this.userdispaly.mainPhoto)
    {
      imgeUrl.push({
        small:photo,
        medium:photo,
        big:photo
      });
      return imgeUrl;
    }
  }
  getUser(){
    //console.log(this.router.snapshot.paramMap.get('userName'))
    this.userServic.getUserByUserName(this.router.snapshot.paramMap.
      get('userName')!)
      .subscribe((memmber)=>
        {
          const userds : UserDispalay =memmber
          console.log(userds)
          this.userdispaly=userds;
        },error=>{
          console.log(error)
        })
  }
}

import { Component, ElementRef, OnChanges, OnDestroy, OnInit,SimpleChanges,ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { InstituteService } from '../Institute.service';
import { Email } from '../model/email';

@Component({
  selector: 'app-InstituteProfile',
  templateUrl: './InstituteProfile.component.html',
  styleUrls: ['./InstituteProfile.component.css']
})
export class InstituteProfileComponent implements OnInit ,OnDestroy {
 ele:any;
 @ViewChild('editInfoDateButton',{static: true}) EditInfoModele!: ElementRef;
 @ViewChild('closeInfoModule',{static: true}) CloseInfoModele!: ElementRef;
 describtionSubject!:Subscription;
 email:Email[]=[];
 describtionstr:string="good describtion from hprofile";
 describtinUnsubscribe!:Subscription;
  constructor(private activeRouter:ActivatedRoute,private router:Router,private instituservice:InstituteService) {

  }
  ngOnDestroy(): void {
    if(this.describtinUnsubscribe){

        this.describtinUnsubscribe.unsubscribe();
    }

  }



  ngOnInit() {
    //console.log("f")

   this.describtionSubject=  this.instituservice.describeEvent.subscribe(response=>{
      if(response){
        console.log(response+"empty")
        console.log(response);
        this.describtionstr=response
      }
    })


    this.email.push({email:'email1'});
  }
ViewFirst(elesd:any){
  //for view in first
  elesd.scrollIntoView({behavior:"smooth",block:"start",inline:"start"})
}
openDescribtionModule(){
  this.EditInfoModele.nativeElement.click();
 // this.instituservice.describeEvent.next(this.describtion)
  this.router.navigate(['editDescribtion'],{relativeTo:this.activeRouter})

}
openContactModule(){
  this.EditInfoModele.nativeElement.click();
  this.router.navigate(['editContact'],{relativeTo:this.activeRouter})
}
openInfoModule(){
  this.EditInfoModele.nativeElement.click();
  this.router.navigate(['editIndo'],{relativeTo:this.activeRouter})
}
CloseInfoModule(){
  this.CloseInfoModele.nativeElement.click();

}
}


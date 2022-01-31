import { Component, ElementRef, OnInit,ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-InstituteProfile',
  templateUrl: './InstituteProfile.component.html',
  styleUrls: ['./InstituteProfile.component.css']
})
export class InstituteProfileComponent implements OnInit {
 ele:any;
 @ViewChild('editInfoDateButton',{static: true}) EditInfoModele!: ElementRef;
 @ViewChild('closeInfoModule',{static: true}) CloseInfoModele!: ElementRef;
  constructor(private activeRouter:ActivatedRoute,private router:Router) {

  }


  ngOnInit() {

  }
ViewFirst(elesd:any){
  elesd.scrollIntoView({behavior:"smooth",block:"start",inline:"start"})
}
openDescribtionModule(){
  this.EditInfoModele.nativeElement.click();
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


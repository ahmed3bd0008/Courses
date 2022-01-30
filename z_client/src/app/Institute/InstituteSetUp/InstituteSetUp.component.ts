import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-InstituteSetUp',
  templateUrl: './InstituteSetUp.component.html',
  styleUrls: ['./InstituteSetUp.component.css']
})
export class InstituteSetUpComponent implements OnInit {

  constructor(private router:Router,private activeRouter:ActivatedRoute ) { }

  ngOnInit() {
  }
  openEditInstituteProfile(){
    alert("gf")
   // this.router.navigate(['../Institute/'+1,'EditInstituteProfile'],{relativeTo:this.activeRouter})
      this.router.navigate([1+'/EditInstituteProfile'],{relativeTo:this.activeRouter})

   }
}

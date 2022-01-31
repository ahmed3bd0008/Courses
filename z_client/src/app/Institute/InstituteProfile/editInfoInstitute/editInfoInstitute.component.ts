
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-editInfoInstitute',
  templateUrl: './editInfoInstitute.component.html',
  styleUrls: ['./editInfoInstitute.component.css']
})
export class EditInfoInstituteComponent implements OnInit {

  constructor(private router:Router,private activeRouter:ActivatedRoute) { }

  ngOnInit() {
  }
  close (){
    this.router.navigate(['../'],{relativeTo:this.activeRouter})
  }
}

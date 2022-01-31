import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-editContactInstitute',
  templateUrl: './editContactInstitute.component.html',
  styleUrls: ['./editContactInstitute.component.css']
})
export class EditContactInstituteComponent implements OnInit {

  contactForm !:FormGroup;
  phoneGroup !:FormArray;
  emailGroup !:FormArray;
  websiteGroup !:FormArray;
  constructor(private router:Router,private activeRouter:ActivatedRoute) {
  }

  ngOnInit() {
    this.contactForm=new FormGroup({
      countery:new FormControl(null),
      city:new FormControl(null),
      Phones:this.phoneGroup
    })
    this.phoneGroup=new FormArray([]);
    this.phoneGroup.push(new FormGroup({
      phone:new FormControl(null),
      phoneType:new FormControl(null),
    }))
  }
 close (){
    this.router.navigate(['../'],{relativeTo:this.activeRouter})
  }
}

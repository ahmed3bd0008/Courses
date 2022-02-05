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
    
    this.phoneGroup=new FormArray([]);
    this.phoneGroup.push(new FormGroup({
      phone:new FormControl(null,[]),
      phoneType:new FormControl(null,[]),
    }))
    this.emailGroup=new FormArray([]);
    this.emailGroup.push(new FormGroup({
      email:new FormControl(null)
    }))

    this.websiteGroup=new FormArray([]);
    this.websiteGroup.push(new FormGroup({
      website:new FormControl(null)
    }))

    this.contactForm=new FormGroup({
      countery:new FormControl(null),
      city:new FormControl(null),
      phones:this.phoneGroup,
      emails:this.emailGroup,
      websites:  this.websiteGroup
    })
  }
  get controlPhones(){
    return (<FormArray>this.contactForm.get('phones')).controls;
  }
  get controltEmail(){
    return (<FormArray>this.contactForm.get('emails')).controls;
  }
  get contactWebsite(){
    return (<FormArray>this.contactForm.get('websites')).controls;
  }

 close (){
    this.router.navigate(['../'],{relativeTo:this.activeRouter})
  }
  addPhone(){
    (<FormArray>this.contactForm.get('phones')).push(
      new FormGroup({
        phone:new FormControl(null,[]),
        phoneType:new FormControl(null,[]),
      })
    )
  }
  deletearrayGrpoup(phonegroupNum:number)
  {
    (<FormArray>this.contactForm.get('phones')).
    removeAt(phonegroupNum)
  }
  addEmail(){
    (<FormArray>this.contactForm.get('emails')).
    push(
      new FormGroup({
        email:new FormControl(null,[]),
      })
    )
  }
  deleteEmail(emailNum:number){
    (<FormArray>this.contactForm.get('emails')).
    removeAt(emailNum)
  }
  addWebsite(){
    (<FormArray>this.contactForm.get('websites')).
    push(
      new FormGroup({
        website:new FormControl(null,[]),
      })
    )
  }
  deleteWebsite(emailNum:number){
    (<FormArray>this.contactForm.get('websites')).
    removeAt(emailNum)
  }
  onsubmite(){
    alert("fsdfsd")
    console.log("gdgsd")
    console.log(this.contactForm)
  }
}

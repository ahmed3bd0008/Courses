import { Data } from "@angular/router";

export interface RegistUser
{
  userName:string;
  email:string;
  birthDate:Date;
  photos:Photo[];
  city:string;
  mainPhoto:string
  phone:string;
  password:string;
  introduction:string;
}

export interface Photo{
  url:string;
  isMain:boolean;
  id:string;
}


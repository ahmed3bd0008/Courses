import { Photo } from "../photos";


export interface User
{
  userName:string;
  password:string;
}
export interface Usertoken
{
  userName:string;
  token:string;
}
export interface UserDispalay
{
  userName: "string"
  city: string
  createDate: Date
  email: string
  age:number;
  introduction: string
  lastActivity: Date
  mainPhoto: string
  phone: string
  photos:Photo[]
}



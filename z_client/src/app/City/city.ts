export interface  city{
  id:string;
  name:string;
}
export interface  addCity{
  name:string;
  counteryId:string;
}

export interface  updateCity{
  id:string;
  name:string;
  counteryId:string;
}
export interface  Countery{
  id:string;
  name:string;
}
export interface  cityCountery{
  id:string;
  name:string;
  counteryId:string;
  countery:Countery;
}
export interface  AddcityCountery{
  name:string;
  counteryId:string;
  countery:Countery;
}


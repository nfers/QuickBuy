import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NumberValueAccessor } from '@angular/forms';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent {
  public users: Users[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Users[]>(baseUrl + 'api/user').subscribe(result => {
      this.users = result;
    }, error => console.error(error));
  }
}

interface Users {
  email: string, 
  password: string, 
  name: string,
  surname: string  
}

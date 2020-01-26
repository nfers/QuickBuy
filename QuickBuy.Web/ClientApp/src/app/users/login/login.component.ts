import { AppComponent } from './../../app.component';
import { Component } from '@angular/core';

@Component({
    selector: "app-login",
    templateUrl: './login.component.html',
     styleUrls: ['./login.component.css']
})

export class LoginComponent {
    public email = '';
    
    entrar() {
     alert(this.email);    
    }    

};
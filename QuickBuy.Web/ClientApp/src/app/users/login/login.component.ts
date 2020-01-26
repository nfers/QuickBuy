import { AppComponent } from './../../app.component';
import { Component } from '@angular/core';
import { User } from 'src/app/models/user.model';

@Component({
    selector: "app-login",
    templateUrl: './login.component.html',
     styleUrls: ['./login.component.css']
})

export class LoginComponent {
    public user;

    constructor() {
        this.user = new User();
    }
    
    
    entrar() {
     alert([' Email: ' + this.user.email + ' Senha: ' + this.user.password]);    
    }    

};
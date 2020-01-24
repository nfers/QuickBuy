import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NumberValueAccessor } from '@angular/forms';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html'
})
export class ProductComponent {
  public prods: Products[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Products[]>(baseUrl + 'api/product').subscribe(result => {
      this.prods = result;
    }, error => console.error(error));
  }
}

interface Products {
  id: number;
  name: string;
  description: string;
  price: number;
}

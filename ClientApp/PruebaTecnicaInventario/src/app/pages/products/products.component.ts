import { Component } from '@angular/core';
import 'devextreme/data/odata/store';
import { ProductService } from 'src/app/api/services';
import { Product } from 'src/app/api/models';

@Component({
  templateUrl: 'products.component.html'
})

export class ProductsComponent {
  public products: Product[] = [];
  isVisible: boolean = false;
  type: string = "info";
  message: string = "";

  constructor(private productService: ProductService) {
    this.getProducts();
  }

  getProducts() {
    this.productService.apiProductGet().subscribe(res => {
      this.products = JSON.parse(res)
    });
  }

  eventListener(e: { data: Product; }, type: string){
    let product: Product;
    product = e.data;

    switch(type) { 
      case "updateRow": { 
        this.updateRow(product);
        break; 
      }
      case "removeRow": { 
        this.removeRow(product);
        break; 
      }
      case "insertRow": { 
        this.insertRow(product);
        break; 
      }
    }
  }

  updateRow(product: Product) {
    this.productService.apiProductPut$Response({ 'body': product }).subscribe(res => {
      this.type = res.ok ? "success" : "error";
      this.message = res.ok ? "product successfully updated" : "An error occurred while updating the product";
      this.isVisible = true;

      this.getProducts();
    });
  }

  removeRow(product: Product) {
    this.productService.apiProductDelete$Response({ 'id': product.id }).subscribe(res => {
      this.type = res.ok ? "success" : "error";
      this.message =  res.ok ? "product successfully deleted" : "An error occurred while deleting the product";
      this.isVisible = true;

      this.getProducts();
    });
  }

  insertRow(product: Product) {
    product.id = 0;
    this.productService.apiProductPost$Response({ 'body': product }).subscribe(res => {
      this.type = res.ok ? "success" : "error";
      this.message = res.ok ? "product successfully added" : "An error occurred while adding the product";
      this.isVisible = true;

      this.getProducts();
    });
  }
}


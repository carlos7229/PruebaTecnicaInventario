import { Component } from '@angular/core';
import { ProductService, ClientService, SaleService } from 'src/app/api/services';
import { Sale, Client, Product } from 'src/app/api/models';
import { DxFormComponent } from 'devextreme-angular';
import notify from 'devextreme/ui/notify';

@Component({
  templateUrl: 'home.component.html',
  styleUrls: [ './home.component.scss' ]
})

export class HomeComponent {
  // @ViewChild(DxFormComponent, { static: false }) form: DxFormComponent;

  formData: Sale = {};
  clients: Client[] = [];
  products: Product[] = [];
  buttonOptions: any = {
    text: "Register",
    type: "success",
    useSubmitBehavior: true
  }

  constructor(private productService: ProductService, private clientService: ClientService, private saleService: SaleService) {
    this.clientService.apiClientGet().subscribe(res => {
      this.clients = JSON.parse(res);
    });

    this.productService.apiProductGet().subscribe(res => {
      this.products = JSON.parse(res);
    });
  }

  onFormSubmit(e: any) {
    let sale: Sale;
    sale = this.formData;

    this.saleService.apiSalePost$Response({ 'body': sale }).subscribe(res => {
      notify({
        message: "Sale successful",
        position: {
            my: "center top",
            at: "center top"
        }
    }, "success", 3000);
      

    });

    e.preventDefault();
}



}

  
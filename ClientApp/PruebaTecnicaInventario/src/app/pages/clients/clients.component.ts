import { Component } from '@angular/core';
import 'devextreme/data/odata/store';
import { ClientService } from 'src/app/api/services';
import { Client } from 'src/app/api/models'; 

@Component({
  templateUrl: 'clients.component.html'
})

export class ClientsComponent {
  public clients: Client[] = [];
  isVisible: boolean = false;
  type: string = "info";
  message: string = "";
  
  constructor(private clientService: ClientService ) {
    this.getClients()
  }

  getClients(){
    this.clientService.apiClientGet().subscribe(res => {
      this.clients = JSON.parse(res)
   });
  }

  eventListener(e: { data: Client; }, type: string){
    let client: Client;
    client = e.data;

    switch(type) { 
      case "updateRow": { 
        this.updateRow(client);
        break; 
      }
      case "removeRow": { 
        this.removeRow(client);
        break; 
      }
      case "insertRow": { 
        this.insertRow(client);
        break; 
      }
    }
  }

    updateRow(client: Client) {
      this.clientService.apiClientPut$Response({ 'body': client }).subscribe(res => {  
        this.type = res.ok ? "success" : "error";
        this.message = res.ok ? "product successfully updated" : "An error occurred while updating the product";
        this.isVisible = true;
        
        this.getClients();
      });
    }
  
    removeRow(client: Client) {
      this.clientService.apiClientDelete$Response({ 'id': client.id }).subscribe(res => {      
        this.type = res.ok ? "success" : "error";
        this.message = res.ok ? "product successfully deleted" : "An error occurred while deleting the product";
        this.isVisible = true;
        
        this.getClients();
      });
    }
  
    insertRow(client: Client) {
      client.id = 0;
      this.clientService.apiClientPost$Response({ 'body': client }).subscribe(res => {
        this.type = res.ok ? "success" : "error";
        this.message = res.ok ? "product successfully added" : "An error occurred while adding the product";
        this.isVisible = true;
        
        this.getClients();
      });
    }
}

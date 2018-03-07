import { Component, OnInit } from '@angular/core';
import { MakeService } from '../../Services/make.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
       // makes:string;
        vehicle:{};


         makes: any[]; 
      models: any[];
      features: any[];
     // vehicle: any = {};
  constructor(private makeService:MakeService) { }

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes=> {
    this.makes=makes;
       console.log("MAKES",this.makes);
       
    });
    
  }
  onMakeChange() {
    // var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
    // this.models = selectedMake ? selectedMake.models : [];
console.log("Makings")
  }
}

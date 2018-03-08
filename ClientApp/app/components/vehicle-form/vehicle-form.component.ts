import { Component, OnInit } from '@angular/core';
import { MakeService } from '../../Services/make.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
       // makes:string;
<<<<<<< HEAD
      //  make:{};


      //    makes: any[]; 
      // models: any[];
      // features: any[];
     // vehicle: any = {};
     makes: any[]; 
     models: any[];
     features: any[];
     make: any = {};
=======
        vehicle:{};


         makes: any[]; 
      models: any[];
      features: any[];
     // vehicle: any = {};
>>>>>>> ccba1ae434a6ed2893407e699662a1ac4d2d56b1
  constructor(private makeService:MakeService) { }

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes=> {
    this.makes=makes;
       console.log("MAKES",this.makes);
       
    });
    
  }
<<<<<<< HEAD
  onMakeChange( ) {
      var selectedMake = this.makes.find((item)=> item.id == this.make.make);
     this.models =  selectedMake ? selectedMake.models : [];
      console.log("id",selectedMake)
=======
  onMakeChange() {
    // var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
    // this.models = selectedMake ? selectedMake.models : [];
console.log("Makings")
>>>>>>> ccba1ae434a6ed2893407e699662a1ac4d2d56b1
  }
}

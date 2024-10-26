import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { PerfectNumberService } from '../perfect-number.service';

@Component({
  selector: 'app-perfect-number',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './perfect-number.component.html',
  styleUrl: './perfect-number.component.css'
})
export class PerfectNumberComponent {
  service: PerfectNumberService = inject(PerfectNumberService);

  boundsForm = new FormGroup({
    minimum: new FormControl(''),
    maximum: new FormControl(''),
  });

  submitPerfectNumberRequest() {
    const min = this.boundsForm.value.minimum;
    const max = this.boundsForm.value.maximum;
    this.service.getPerfectNumbersBetween(1, 10).then(({count}) =>
      console.log(`c: ${count}`)
    );
  }
}

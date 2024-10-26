import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PerfectNumberComponent } from './perfect-number.component';

describe('PerfectNumberComponent', () => {
  let component: PerfectNumberComponent;
  let fixture: ComponentFixture<PerfectNumberComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PerfectNumberComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PerfectNumberComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

/**
 * Generated by orval v6.5.1 🍺
 * Do not edit manually.
 * Navtrack.Api
 * OpenAPI spec version: 1.0
 */
import type { LocationModel } from './locationModel';

export interface AssetModel {
  id: string;
  readonly shortId: string;
  name: string;
  readonly online: boolean;
  readonly maxSpeed: number;
  location?: LocationModel;
}
